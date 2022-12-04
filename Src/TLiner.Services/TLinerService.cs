using TLiner.Domain.Abstractions.Services;

namespace TLiner.Services
{
    public class TLinerService : ITLinerService
    {
        private readonly IAppState appState;
        private readonly IAttributeModelService? attributeModelService;
        private readonly IAttributeService? attributeService;
        private readonly IEntityModelService? entityModelService;
        private readonly IEntityService? entityService;
        private readonly IProjectService? projectService;
        private readonly IRelationModelService? relationModelService;
        private readonly IRelationService? relationService;
        private readonly ITimeUnitModelService? timeUnitModelService;

        public TLinerService(IAppState appState, IServiceAggregator serviceAggregator)
        {
            this.appState = appState;
            attributeModelService = serviceAggregator.AttributeModelService;
            attributeService = serviceAggregator.AttributeService;
            entityModelService = serviceAggregator.EntityModelService;
            entityService = serviceAggregator.EntityService;
            projectService = serviceAggregator.ProjectService;
            relationModelService = serviceAggregator.RelationModelService;
            relationService = serviceAggregator.RelationService;
            timeUnitModelService = serviceAggregator.TimeUnitModelService;
        }
    }
}