using DesignPattern_ChainOfResponsibilty.Models;

namespace DesignPattern_ChainOfResponsibilty.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextAppRover;
        public void SetNextAppRover(Employee supervisor)
        {
            this.NextAppRover = supervisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
