namespace ProfileConnectionLib.ConnectionServices.DtoModels.UserNameLists
{
    public record UserList
    {
        public required string Name { get; init; }

        public required Guid UserId { get; init; }
    }
}
