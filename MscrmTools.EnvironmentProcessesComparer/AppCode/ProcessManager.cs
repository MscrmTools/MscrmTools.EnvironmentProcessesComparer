using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Collections.Generic;
using System.Linq;

namespace MscrmTools.EnvironmentProcessesComparer.AppCode
{
    public class ProcessManager
    {
        private readonly IOrganizationService _service;

        public ProcessManager(IOrganizationService service)
        {
            _service = service;
        }

        public List<Entity> LoadProcesses(List<Entity> solutions = null)
        {
            var query = new QueryExpression("workflow")
            {
                NoLock = true,
                ColumnSet = new ColumnSet("name", "category", "statecode", "primaryentity"),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("type", ConditionOperator.Equal, 1)
                    }
                }
            };

            if (solutions?.Count > 0)
            {
                query.LinkEntities.Add(new LinkEntity
                {
                    LinkFromEntityName = "workflow",
                    LinkFromAttributeName = "workflowid",
                    LinkToAttributeName = "objectid",
                    LinkToEntityName = "solutioncomponent",
                    LinkEntities =
                    {
                        new LinkEntity
                        {
                            LinkFromEntityName = "solutioncomponent",
                            LinkFromAttributeName = "solutionid",
                            LinkToAttributeName = "solutionid",
                            LinkToEntityName = "solution",
                            LinkCriteria = new FilterExpression
                            {
                                Conditions =
                                {
                                    new ConditionExpression("uniquename", ConditionOperator.In, solutions.Select(s => s.GetAttributeValue<string>("uniquename")).ToArray())
                                }
                            }
                        }
                    }
                });
            }

            return _service.RetrieveMultiple(query).Entities.ToList();
        }
    }
}