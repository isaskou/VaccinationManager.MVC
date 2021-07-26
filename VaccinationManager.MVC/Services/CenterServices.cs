using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinationManager.DAL;
using VaccinationManager.Models.Center;
using VaccinationManager.MVC.Models.ListCenter;
using VaccinationManager.MVC.Models.Personnel;

namespace VaccinationManager.MVC.Services
{
    public class CenterServices : BaseService, IService<CenterModel>
    {
        private readonly VaccinationCenter _vc;


        public CenterServices(DataContext dc, VaccinationCenter vc) : base(dc)
        {
            _vc = vc;
        }

        public CenterModel Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CenterModel> GetAll()
        {
            IEnumerable<VaccinationCenter> centerModels = _dc.vaccinationCenters;
                ;

            return 
                centerModels.Select(cm => new CenterModel
            {
                Id = cm.Id,
                Name=cm.Name,
                CompleteAdress = cm.Adress.Street + " " + cm.Adress.Number + " - " + cm.Adress.PostalCode + " " + cm.Adress.City + " " + cm.Adress.District,
                ResponsableName = cm.Manager.Staff.Person.FirstName + " " + cm.Manager.Staff.Person.LastName,
            });
        }

        public CenterModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CenterModel Insert(CenterModel entity)
        {
            throw new NotImplementedException();
        }

        public CenterModel Update(CenterModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
