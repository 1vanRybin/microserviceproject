
namespace ProfileConnectionLib.ConnectionServices.DtoModels.UserNameLists
{
    public record UserNameListProfileApiRequest
    {
        public required List<Guid> UserIdList { get; init; }
    }
}

