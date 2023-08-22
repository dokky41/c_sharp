using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interface_Segregation
{

        interface IGun
        {
            // 발사
            public void Shot();

            // 장전
            public void reload();
        }

        interface IScope
        {
            // 줌
            public void Zoom(float value);
        }

    
}
