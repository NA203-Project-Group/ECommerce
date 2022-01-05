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
    public class CampaignDetailManager : ICampaignDetailService
    {
        private ICampaignDetailDal _campaignDetailDal;

        public CampaignDetailManager(ICampaignDetailDal campaignDetailDal)
        {
            _campaignDetailDal = campaignDetailDal;
        }


        public IDataResult<List<CampaignDetail>> GetAll()
        {
            return new SuccessDataResult<List<CampaignDetail>>(_campaignDetailDal.GetAll());
        }

        public IDataResult<CampaignDetail> Get(int id)
        {
            return new SuccessDataResult<CampaignDetail>(_campaignDetailDal.Get(cD => cD.CampaingDetailID == id));
        }

        public IResult Add(CampaignDetail entity)
        {
            _campaignDetailDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(CampaignDetail entity)
        {
            _campaignDetailDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(CampaignDetail entity)
        {
            _campaignDetailDal.Delete(entity);
            return new SuccessResult();
        }
    }
}
