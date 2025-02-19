using HotelManagement.Application.Interfaces;
using HotelManagement.Domain.Entities;
using HotelManagement.Infrastructure.Data;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Infrastructure.Repository
{
	public class ThanhToanRepository : Repository<ThanhToan>, IThanhToanRepository
	{
		private readonly ApplicationDbContext _context;
		public ThanhToanRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}

		public ApiResponse generateQRCode(APIRequest apiRequest)
		{
			var jsonRequest = JsonConvert.SerializeObject(apiRequest);
			// use restsharp for request api.
			var client = new RestClient("https://api.vietqr.io/v2/generate");
			var request = new RestRequest();

			request.Method = Method.Post;
			request.AddHeader("Accept", "application/json");

			request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

			var response = client.Execute(request, Method.Post);
			var content = response.Content;
			return JsonConvert.DeserializeObject<ApiResponse>(content);
		}

		public void Update(ThanhToan ThanhToan)
		{
			_context.ThanhToan.Update(ThanhToan);
		}
	}
}
