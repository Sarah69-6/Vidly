using Vidly.Models;

namespace Vidly.Controllers
{
    internal class CustomerFormViewModel
    {
        public CustomerFormViewModel()
        {
        }

        public Customer Customer { get; internal set; }
        public object MembershipTypes { get; internal set; }
    }
}