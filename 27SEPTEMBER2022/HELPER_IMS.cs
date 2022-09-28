using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_IMS;
using DAL_IMS;

namespace HELPER_IMS
{
    public class HELPER_IMSS
    {
        DAL_IMS_class dal = null;
        public HELPER_IMSS()
        {
            dal = new DAL_IMS_class();
        }


        public int RowCount()
        {
            return dal.RowCount();

        }
        public bool AddNew(BLL_Course COURSE)
        {
            return dal.Insert(COURSE);
        }
        public BLL_Course Locate(BLL_Course course)
        {

            return dal.Find(course.CourseID);
        }

        public List<BLL_Course> EmployeeList()
        {
            return dal.ShowAll();
        }

        public bool Remove(BLL_Course Course)
        {
            return dal.Delete(Course.CourseID);
        }



        public bool Edit(BLL_Course Course)
        {
            return dal.Update(Course.CourseID,Course);
        }



    }


}
