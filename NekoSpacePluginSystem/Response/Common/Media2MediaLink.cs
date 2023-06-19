namespace NekoSpace.Seed.Models
{
    public class Media2MediaLink
    {
        public MediaTypeEnum MediaType { get; } // Тип об'єкту, тобто чим він є
        public RelationTypeEnum RelationType { get; } // Тип зв'язку, тобто чим він являється для основного твору
        public ResourceEnum Resource { get; } // З якого ресурсу походить даний твір
        public string Id { get; } // Id того товру на тому ресурсі

        public Media2MediaLink(MediaTypeEnum mediaType, RelationTypeEnum relationType, ResourceEnum resource, string id)
        {
            MediaType = mediaType;
            RelationType = relationType;
            Resource = resource;
            Id = id;
        }
    }
}
