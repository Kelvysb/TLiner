namespace TLiner.Domain.Abstractions.Services
{
    public interface IServiceAggregator
    {
        public IAttributeModelService? AttributeModelService { get; set; }

        public IAttributeService? AttributeService { get; set; }

        public IEntityModelService? EntityModelService { get; set; }

        public IEntityService? EntityService { get; set; }

        public IProjectService? ProjectService { get; set; }

        public IRelationModelService? RelationModelService { get; set; }

        public IRelationService? RelationService { get; set; }

        public ITimeUnitModelService? TimeUnitModelService { get; set; }
    }
}