
namespace HealthCare.SharedAssets
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; }
    }
}