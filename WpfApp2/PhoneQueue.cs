using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class PhoneQueue
    {
        private Queue<Phone> _phones = new Queue<Phone>();

        public void AddPhone(Phone phone)
        {
            _phones.Enqueue(phone);
        }

        public Phone RemoveFirstPhone()
        {
            return _phones.Dequeue();
        }

        public List<Phone> GetAllPhones()
        {
            return _phones.ToList();
        }
    }
}
