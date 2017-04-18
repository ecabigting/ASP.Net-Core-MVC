using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses {  get { return responses; } }
        public static void AddResponse(GuestResponse response) { responses.Add(response); }
        public static void poprepo()
        {
            responses.Add(new GuestResponse { Name = "Tony Stark", Email="t.stark@starkindustries.com", Phone="390-3214", WillAttend= true });
            responses.Add(new GuestResponse { Name = "Bruce Banner", Email="bruce.banner@smashsmash.ca", Phone="678-9018", WillAttend = false });
            responses.Add(new GuestResponse { Name = "Thor Odinson", Email="thorsodinson@asgardonline.com", Phone="102-3841", WillAttend = true });
            responses.Add(new GuestResponse { Name = "Clint Borton", Email="borton_clint@arrowenthusiast.com", Phone="555-9802", WillAttend = true });
            responses.Add(new GuestResponse { Name="Steve Rogers", Email="steve.r@patriotsunited.org", Phone="892-9871",WillAttend=true });
        }
    }
}
