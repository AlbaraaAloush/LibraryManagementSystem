using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class DVD : LibraryItem
    {
        private int durationMinutes;

        public int DurationMinutes
        {
            get => durationMinutes;
            private set
            {
                durationMinutes = value >= 1 ? value : throw new ArgumentOutOfRangeException(nameof(value), value, "DVD duration cannot be less than 1 minute"); 
            }
        }

        public DVD(string title, int durationMinutes)
            : base(title)
        {
            DurationMinutes = durationMinutes;
        }

        public override int GetBorrowDuration()
        {
            return 7;
        }
        public override string ToString()
        {
            return $"{base.ToString()} | Duration: {durationMinutes} min";
        }
    }
}
