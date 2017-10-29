using Newtonsoft.Json.Linq;

namespace o365Core.sharedClasses
{
    public class SubscriptionHelper
    {
        public static JObject FilterSkusByPartNumber (JArray skus, string skuPartNumber)
        {
            foreach (JToken sku in skus)
            {
                JObject skuObject = (JObject)sku;

                if ((string)skuObject["skuPartNumber"] == skuPartNumber)
                {
                    skuObject = (JObject)sku;
                    return skuObject;
                }
            }
            return new JObject();
        }

        public static JObject FilterSkusBySkuId(JArray skus, string skuId)
        {
            foreach (JToken sku in skus)
            {
                JObject skuObject = (JObject)sku;

                if ((string)skuObject["skuId"] == skuId)
                {
                    skuObject = (JObject)sku;
                    return skuObject;
                }
            }
            return new JObject();
        }
    }
}