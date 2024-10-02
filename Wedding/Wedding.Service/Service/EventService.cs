using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using AutoMapper;
using Wedding.Model.Domain;
using Wedding.Model.DTO;
using Wedding.Service.IService;
using Microsoft.Extensions.Configuration;
using Wedding.DataAccess.IRepository;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;

namespace Wedding.Service.Service;

public class EventService : IEventService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUnitOfWork _unitOfWork;

    public EventService(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
        _unitOfWork = unitOfWork;
    }
    public async Task<ResponseDTO> GetAll(ClaimsPrincipal User, string? filterOn, string? filterQuery, string? sortBy, bool? isAscending,
        int pageNumber, int pageSize)
    {
        #region MyRegion

        try
        {
            List<Event> Events = new List<Event>();

            // Filter Query
            if (!string.IsNullOrEmpty(filterOn) && !string.IsNullOrEmpty(filterQuery))
            {
                switch (filterOn.Trim().ToLower())
                {
                    case "bridgename":
                        {
                            Events = _unitOfWork.EventRepository.GetAllAsync(includeProperties: "ApplicationUser")
                                .GetAwaiter().GetResult().Where(x =>
                                    x.BrideName.Contains(filterQuery, StringComparison.CurrentCultureIgnoreCase)).ToList();
                            break;
                        }
                    case "groomname":
                        {
                            Events = _unitOfWork.EventRepository.GetAllAsync(includeProperties: "ApplicationUser")
                                .GetAwaiter().GetResult().Where(x =>
                                    x.GroomName.Contains(filterQuery, StringComparison.CurrentCultureIgnoreCase)).ToList();
                            break;
                        }

                    case "eventlocation":
                        {
                            Events = _unitOfWork.EventRepository.GetAllAsync(includeProperties: "ApplicationUser")
                                .GetAwaiter().GetResult().Where(x =>
                                    x.EventLocation.Contains(filterQuery, StringComparison.CurrentCultureIgnoreCase)).ToList();
                            break;
                        }
                    default:
                        {
                            Events = _unitOfWork.EventRepository
                                .GetAllAsync(includeProperties: "ApplicationUser")
                                .GetAwaiter().GetResult().ToList();
                            break;
                        }
                }
            }
            else
            {
                Events = _unitOfWork.EventRepository.GetAllAsync(includeProperties: "ApplicationUser")
                    .GetAwaiter().GetResult().ToList();
            }

            // Sort Query
            if (!string.IsNullOrEmpty(sortBy))
            {
                switch (sortBy.Trim().ToLower())
                {
                    case "bridgename":
                        {
                            Events = isAscending == true
                                ? Events.OrderBy(x => x.BrideName).ToList()
                                : Events.OrderByDescending(x => x.BrideName).ToList();
                            break;
                        }
                    case "groomname":
                        {
                            Events = isAscending == true
                                ? Events.OrderBy(x => x.GroomName).ToList()
                                : Events.OrderByDescending(x => x.GroomName).ToList();
                            break;
                        }
                    case "eventlocation":
                        {
                            Events = isAscending == true
                                ? Events.OrderBy(x => x.EventLocation).ToList()
                                : Events.OrderByDescending(x => x.EventLocation).ToList();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }

            // Pagination
            if (pageNumber > 0 && pageSize > 0)
            {
                var skipResult = (pageNumber - 1) * pageSize;
                Events = Events.Skip(skipResult).Take(pageSize).ToList();
            }

            #endregion Query Parameters

            if (Events == null || !Events.Any())
            {
                return new ResponseDTO()
                {
                    Message = "No events found",
                    IsSuccess = false,
                    StatusCode = 404,
                    Result = null
                };
            }

            var EventDtoList = new List<EventDTO>();

            foreach (var Event in Events)
            {
                var EventDTO = new EventDTO
                {
                    EventId = Event.EventId,
                    WeddingId = Event.WeddingId,
                    BrideName = Event.BrideName,
                    GroomName = Event.GroomName,
                    EventDate = Event.EventDate,
                    EventLocation = Event.EventLocation,
                    EventPhotoUrl = Event.EventPhotoUrl,
                    CreatedDate = Event.CreatedDate,
                };

                EventDtoList.Add(EventDTO);
            }

            return new ResponseDTO()
            {
                Message = "Get all events successfully",
                Result = EventDtoList,
                IsSuccess = true,
                StatusCode = 200
            };
        }
        catch (Exception e)
        {
            return new ResponseDTO()
            {
                Message = e.Message,
                Result = null,
                IsSuccess = false,
                StatusCode = 500
            };
        }
    }

    public async Task<ResponseDTO> GetById(Guid id)
    {
        {
            try
            {
                var Event = await _unitOfWork.EventRepository.GetById(id);
                if (Event is null)
                {
                    return new ResponseDTO()
                    {
                        Message = "Events was not found",
                        IsSuccess = false,
                        StatusCode = 404,
                        Result = null
                    };
                }

                EventDTO EventDto = new EventDTO()
                {
                    EventId = Event.EventId,
                    WeddingId = Event.WeddingId,
                    BrideName = Event.BrideName,
                    GroomName = Event.GroomName,
                    EventDate = Event.EventDate,
                    EventLocation = Event.EventLocation,
                    EventPhotoUrl = Event.EventPhotoUrl,
                    CreatedDate = Event.CreatedDate,
                };

                return new ResponseDTO()
                {
                    Message = "Get event successfully ",
                    IsSuccess = false,
                    StatusCode = 200,
                    Result = EventDto
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO()
                {
                    Message = e.Message,
                    IsSuccess = false,
                    StatusCode = 500,
                    Result = null
                };
            }
        }
    }

    public async Task<ResponseDTO> UpdateById(UpdateEventDTO updateEventDTO)
    {
        try
        {
            var EventToUpdate = await _unitOfWork.EventRepository.GetById(updateEventDTO.EventId);
            if (EventToUpdate is null)
            {
                return new ResponseDTO()
                {
                    Message = "Event was not found",
                    IsSuccess = false,
                    StatusCode = 404,
                    Result = null
                };
            }

            EventToUpdate.EventDate = updateEventDTO.EventDate;
            EventToUpdate.EventLocation = updateEventDTO.EventLocation;
            EventToUpdate.EventPhotoUrl = updateEventDTO.EventPhotoUrl;
            EventToUpdate.CreatedDate = updateEventDTO.CreatedDate;

            _unitOfWork.EventRepository.Update(EventToUpdate);
            await _unitOfWork.SaveAsync();

            return new ResponseDTO()
            {
                Message = "Event updated successfully",
                IsSuccess = true,
                StatusCode = 200,
                Result = null
            };
        }
        catch (Exception e)
        {
            return new ResponseDTO()
            {
                Message = e.Message,
                IsSuccess = false,
                StatusCode = 500,
                Result = null
            };
        }
    }

    public async Task<ResponseDTO> DeleteById(Guid id)
    {
        try
        {
            var Event = await _unitOfWork.EventRepository.GetById(id);
            if (Event is null)
            {
                return new ResponseDTO()
                {
                    Message = "Event was not found",
                    IsSuccess = false,
                    StatusCode = 404,
                    Result = null
                };
            }

            _unitOfWork.EventRepository.Remove(Event);
            await _unitOfWork.SaveAsync();

            return new ResponseDTO()
            {
                Message = "Event deleted successfully",
                IsSuccess = true,
                StatusCode = 200,
                Result = null
            };
        }
        catch (Exception e)
        {
            return new ResponseDTO()
            {
                Message = e.Message,
                IsSuccess = false,
                StatusCode = 500,
                Result = null
            };
        }
    }

    public async Task<ResponseDTO> CreateById(CreateEventDTO createEventDTO)
    {
        try
        {
            var wedding = await _unitOfWork.WeddingRepository.GetById(createEventDTO.WeddingId);

            if (wedding != null)
            {
                createEventDTO.BrideName = wedding.BrideName;
                createEventDTO.GroomName = wedding.GroomName;
            }

            var Event = new Event
            {
                EventId = Guid.NewGuid(),
                WeddingId = createEventDTO.WeddingId,
                EventDate = createEventDTO.EventDate,
                EventLocation = createEventDTO.EventLocation,
                EventPhotoUrl = createEventDTO.EventPhotoUrl,
                CreatedDate = createEventDTO.CreatedDate,
            };

            await _unitOfWork.EventRepository.AddAsync(Event);
            await _unitOfWork.SaveAsync();

            return new ResponseDTO()
            {
                Message = "Event created successfully",
                IsSuccess = true,
                StatusCode = 201,
                Result = Event
            };
        }
        catch (Exception e)
        {
            return new ResponseDTO()
            {
                Message = e.Message,
                IsSuccess = false,
                StatusCode = 500,
                Result = null
            };
        }
    }
}