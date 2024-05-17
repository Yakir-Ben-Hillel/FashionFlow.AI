using System.ComponentModel.DataAnnotations.Schema;

namespace FashionFlow.API.Models.Hierarchies
{
    [Table("HierarchyProgrammas")]
    public class HierarchyProgramma : BaseConfigurationEntity
    {
        public int HierarchyProductTypeId { get; set; }
    }
}
