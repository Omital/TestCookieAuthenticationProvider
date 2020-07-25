using Abp.Web.Mvc.Views;

namespace AdsTest.Web.Views
{
    public abstract class AdsTestWebViewPageBase : AdsTestWebViewPageBase<dynamic>
    {

    }

    public abstract class AdsTestWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AdsTestWebViewPageBase()
        {
            LocalizationSourceName = AdsTestConsts.LocalizationSourceName;
        }
    }
}