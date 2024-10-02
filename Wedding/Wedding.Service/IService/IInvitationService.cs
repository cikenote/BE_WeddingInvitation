using System.Security.Claims;
using Wedding.Model.DTO;
using Wedding.Model.Domain;

namespace Wedding.Service.IService;

public interface IInvitationService
{
    Task<ResponseDTO> GetAll
    (
        ClaimsPrincipal User,
        string? filterOn,
        string? filterQuery,
        string? sortBy,
        bool? isAscending,
        int pageNumber,
        int pageSize
    );

    Task<ResponseDTO> GetById(Guid id);
    Task<ResponseDTO> UpdateById(UpdateInvitationDTO updateInvitationDTO);
    Task<ResponseDTO> DeleteById(Guid id);
    Task<ResponseDTO> CreateById(CreateInvitationDTO createInvitationDTO);
}