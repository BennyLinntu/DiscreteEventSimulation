using RandomVariateGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomVariateGeneratorLibrary
{
    public class DES_Collection_Element_Editor : CollectionEditor
    {
        public static event EventHandler<DESElement> DES_Element_Add;
        Type[] candidate_Types;
        public DES_Collection_Element_Editor(Type t) : base(t)
        {
            if (t == typeof(Server))
            {
                //candidate_Types = new Type[2] { typeof(Server), typeof(Machine) };
            }
            else
            {
                candidate_Types = new Type[1] { t };
            }
        }

        protected override Type[] CreateNewItemTypes()
        {
            return candidate_Types;
        }

        protected override object CreateInstance(Type itemType)
        {
            object o = base.CreateInstance(itemType);
            if (o is DESElement && DES_Element_Add != null)
                DES_Element_Add(this, (DESElement)o);
            return o;
        }
    }
}
