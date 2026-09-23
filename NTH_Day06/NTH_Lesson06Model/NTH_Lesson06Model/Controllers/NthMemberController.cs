using Microsoft.AspNetCore.Mvc;
using NTH_Lesson06Model.Models;

namespace NTH_Lesson06Model.Controllers
{
    public class NthMemberController : Controller
    {
        //mock Data
        private static readonly List<NthMember> _nthMembers = new List<NthMember>()
    {
        new NthMember
        {
            NthMemberId = Guid.NewGuid().ToString(),
            NthMemberUserName = "Thanh Hải",
            NthMemberPassword = "Password@123",
            NthMemberEmail = "hainguyen@gmail.com",
            NthMemberFullName = "Nguyễn Thanh Hải"
        },
        new NthMember
        {
            NthMemberId = Guid.NewGuid().ToString(),
            NthMemberUserName = "tranthib",
            NthMemberPassword = "Password@123",
            NthMemberEmail = "tranthib@gmail.com",
            NthMemberFullName = "Trần Thị B"
        },
        new NthMember
        {
            NthMemberId = Guid.NewGuid().ToString(),
            NthMemberUserName = "levanc",
            NthMemberPassword = "Password@123",
            NthMemberEmail = "levanc@gmail.com",
            NthMemberFullName = "Lê Văn C"
        },
        new NthMember
        {
            NthMemberId = Guid.NewGuid().ToString(),
            NthMemberUserName = "phamthid",
            NthMemberPassword = "Password@123",
            NthMemberEmail = "phamthid@gmail.com",
            NthMemberFullName = "Phạm Thị D"
        },
        new NthMember
        {
            NthMemberId = Guid.NewGuid().ToString(),
            NthMemberUserName = "hoangvane",
            NthMemberPassword = "Password@123",
            NthMemberEmail = "hoangvane@gmail.com",
            NthMemberFullName = "Hoàng Văn E"
        }
    };

        //Get: List(đây là danh sách)
        public IActionResult NthIndex()
        {
            return View(_nthMembers);
        }

        //Create
        public IActionResult NthCreate()
        {
            return View();
        }

        //Create - submit form
        [HttpPost]
        public IActionResult NthCreate(NthMember nthMember)
        {
            nthMember.NthMemberId = Guid.NewGuid().ToString();
            _nthMembers.Add(nthMember);
            return RedirectToAction("NthIndex");
        }

        //Edit
        public IActionResult NthEdit(string id)
        {
            var nthMember = _nthMembers.FirstOrDefault(x=>x.NthMemberId.Equals(id));
            return View(nthMember);
        }

        [HttpPost]
        public IActionResult NthEdit(string id, NthMember nthMember)
        {
            for(int i = 0; i < _nthMembers.Count; i++)
            {
                if (_nthMembers[i].NthMemberId == id)
                {
                    _nthMembers[i].NthMemberId = nthMember.NthMemberId;
                    _nthMembers[i].NthMemberUserName = nthMember.NthMemberUserName;
                    _nthMembers[i].NthMemberPassword = nthMember.NthMemberPassword;
                    _nthMembers[i].NthMemberFullName = nthMember.NthMemberFullName;
                    _nthMembers[i].NthMemberEmail = nthMember.NthMemberEmail;

                    break;
                }
            }   


            return RedirectToAction("NthIndex");
        }

        //Delete
        public IActionResult NthDelete(string id)
        {
            var nthMember = _nthMembers.FirstOrDefault(x=>x.NthMemberId == id);
            if(nthMember == null)
            {
                return NotFound();
            }

            return View(nthMember);
        }

        [HttpPost]
        [ActionName("NthDelete")]
        public IActionResult NthDeleteConfirmed(string id)
        {
            var nthMember = _nthMembers.FirstOrDefault(x => x.NthMemberId == id);
            if (nthMember == null)
            {
                return NotFound();
            }

            _nthMembers.Remove(nthMember);
            return RedirectToAction("NthIndex");
        }
        public IActionResult NthGetDetails()
        {
            var nthMember = new NthMember()
            {
                NthMemberId = Guid.NewGuid().ToString(),
                NthMemberUserName = "Thanh Hải",
                NthMemberPassword = "password",
                NthMemberFullName = "Nguyễn Thanh Hải",
                NthMemberEmail = "hainguyen@gamil.com"
            };
            return View(nthMember);
        }
    }
}
