using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        private ICampaignDal _campaignDal;

        public CampaignManager(ICampaignDal campaignDal)
        {
            _campaignDal = campaignDal;
        }


        public IDataResult<List<Campaign>> GetAll()
        {
            return new SuccessDataResult<List<Campaign>>(_campaignDal.GetAll());
        }

        public IDataResult<Campaign> Get(int id)
        {
            return new SuccessDataResult<Campaign>(_campaignDal.Get(c => c.CampaingID == id));
        }

        public IResult Add(Campaign entity)
        {
            _campaignDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(Campaign entity)
        {
            _campaignDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(Campaign entity)
        {
            _campaignDal.Delete(entity);
            return new SuccessResult();
        }
    }
}
