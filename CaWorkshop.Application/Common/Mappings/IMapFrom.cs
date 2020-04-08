using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CaWorkshop.Application.Common.Mappings
{
    public interface IMapFrom<T>
    {
        void Mapping(Profile profile);
    }
}
