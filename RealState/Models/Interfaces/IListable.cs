using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Models.Interfaces
{
    public interface IListable
    {
        int GetId();
        string GetTitle();
        string GetGetails();
        string GetSearchFieldName();
        Image GetProfileImage();

    }
}
