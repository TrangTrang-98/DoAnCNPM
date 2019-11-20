using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities.ExRegisterAggregate
{
    public class ExForm : IAggregateRoot
    {
        public string ExFormID{get; private set;}
        public string ExFormName{get; private set;}
    }
}