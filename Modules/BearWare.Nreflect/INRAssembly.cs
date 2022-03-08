// NReflect - Easy assembly reflection
// Copyright (C) 2010-2011 Malte Ried
//
// This file is part of NReflect.
//
// NReflect is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// NReflect is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with NReflect. If not, see <http://www.gnu.org/licenses/>.

using NReflect.NRAttributes;
using NReflect.NREntities;
using System.Collections.Generic;

namespace NReflect
{
    public interface INRAssembly
    {
        List<NRAttribute> Attributes { get; }
        List<NRClass> Classes { get; }
        IEnumerable<NRCompositeType> CompositTypes { get; }
        List<NRDelegate> Delegates { get; }
        List<NREnum> Enums { get; }
        string FullName { get; set; }
        List<NRInterface> Interfaces { get; }
        List<NRModule> Modules { get; }
        IEnumerable<NRSingleInheritanceType> SingleInheritanceTypes { get; }
        string Source { get; set; }
        List<NRStruct> Structs { get; }
        IEnumerable<NRTypeBase> Types { get; }

        void Accept(IVisitor visitor);
    }
}