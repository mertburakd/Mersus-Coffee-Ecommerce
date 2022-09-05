using Buisness.Abstract;
using Business.Constants;
using Core.Results;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concrete
{
    public class AdressManager : IAdressService
    {
        private readonly IAdressDal _adressDal;

        public AdressManager(IAdressDal adressDal)
        {
            _adressDal = adressDal;
        }

        public IResult Add(Adress adress)
        {
            _adressDal.Add(adress);
            return new SuccessResult(Messages.AdressAdded);
        }



        public IDataResult<Adress> GetUserLastAdress(int UserID)
        {
            return new SuccessDataResult<Adress>(_adressDal.LastAddress(UserID));
        }
    }
}
