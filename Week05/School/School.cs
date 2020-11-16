using System.Collections.Generic;

namespace School
{
    internal class School
    {
        public List<Classes> SchoolClasses = new List<Classes>();
        public School(List<Classes> schoolClasses)
        {
            this.SchoolClasses = schoolClasses;
        }
    }
}