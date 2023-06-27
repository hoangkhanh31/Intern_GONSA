using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using RestSharp;

namespace DAL
{
    public class TrangThaiGiaoHangDAO
    {
        public TrangThaiGiaoHangDAO()
        {
            
        }
    public List<TrangThaiGiaoHangDTO>? GetList()
        {
            Uri Url = new Uri("http://data.gonsa.com.vn/api/order/getTrangThaiGiaoHang");
            var restClient = new RestClient(Url);
            RestRequest restRequest = new RestRequest("", Method.Get);
            var restResponse = restClient.Execute<List<TrangThaiGiaoHangDTO>>(restRequest);

            if (restResponse.IsSuccessful)
            {
                return restResponse.Data;
            }
            else
            {
                Console.WriteLine(restResponse.ErrorMessage);
                return null;
            }
        }
    }
}
