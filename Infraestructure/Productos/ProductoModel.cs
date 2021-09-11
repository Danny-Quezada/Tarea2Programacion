using Domain.Entities;
using Domain.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Productos
{
     

    public class ProductoModel
    {
        public Producto[] productos;
        
        #region CRUD
           
        public Producto[] GetAll()
        {
            return productos;
        }
        public void Update(Producto p)
        {
            for(int i=0; i<productos.Length; i++)
			{
				if (p.Id == productos[i].Id)
				{
                    productos[i] = p;
				}
			}
           
        }
        public void Add(Producto p)
		{
            if (productos == null)
            {
                productos = new Producto[1];
                productos[0] = p;
            }
            else
            {
                Producto[] tmp = new Producto[productos.Length + 1];
				Array.Copy(productos, tmp, productos.Length);
                tmp[tmp.Length - 1] = p;
				productos = new Producto[tmp.Length];
                
                productos = tmp;
            }
	    }

			#endregion
			private void Add(Producto p, ref Producto[] pds)
        {
            if (pds == null)
            {
                pds = new Producto[1];
                pds[0] = p;
                
            }
			
                Producto[] tmp = new Producto[pds.Length + 1];
				Array.Copy(pds, tmp, pds.Length);
                tmp[tmp.Length - 1] = p;
				pds = tmp;

            
        }
        public bool Delete(Producto p)
        {
            int index = GetIndexById(p);
            if (index < 0)
            {
                throw new Exception($"El producto con Id{p.Id} no se encontro");
            }
            if (index != productos.Length - 1)
            {
                productos[index] = productos[productos.Length - 1];
            }
            Producto[] tmp = new Producto[productos.Length - 1];
            Array.Copy(productos, tmp, tmp.Length);
            productos = tmp;
            return productos.Length == tmp.Length;
        }
        private int GetIndexById(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }
            int index = int.MinValue;

            if (productos == null)
            {
                return index;
            }
            int i = 0;
            foreach (Producto pd in productos)
            {
                if (pd.Id == p.Id)
                {
                    index = i;
                    break;
                }
                i++;
            }
            return index;
        }
        //añadir como parametro un producto p
        public Producto GetProductoById(int id)
		{
            //Array.Sort(productos, new Producto.ProductoIdCompare());
            //         Producto prueba = new Producto { Id = id };
            //int index = Array.BinarySearch(productos, prueba,new Producto.ProductoIdCompare());
            Array.Sort(productos, new Producto.ProductoIdCompare());
            for(int i=0; i<productos.Length; i++)
			{
				if (id == productos[i].Id)
				{
                    return productos[i];
				}
			}
            return null;
        }
        public Producto[] DeleteBy(Producto p)
        {
            int index = GetIndexById(p);
            Producto[] tmp = new Producto[productos.Length - 1];
            int j = 0;
            for (int i = 0; i < productos.Length; i++)
            {
				if (tmp.Length == 0)
				{
                    break;
				}
                        
                tmp[j] = productos[i];
                if (j == tmp.Length - 1)
                {
                    break;
                }
                if (i == index)
                {
                    tmp[j] = productos[i + 1];
                    i++;
                }
                j++;
            }
            productos = new Producto[tmp.Length];
            productos = tmp;
            return productos;

        }
        public Producto[] GetProductosByUnidadMedida(UnidadMedida um)
        {
            Producto[] tmp = null;
            foreach(Producto p in productos)
            {
                if (p.UnidadMedida == um)
                {
                    Add(p, ref tmp);
                }
            }
            return tmp;
        }
        public Producto[] GetProductosByRangoPrecio(decimal start,decimal end)
        {
            Producto[] tmp = null;
            if (productos == null)
            {
                return tmp;
            }
            foreach(Producto p in productos)
            {
                if(p.Precio>=start && p.Precio <= end)
                {
                    Add(p, ref tmp);
                }
            }
            return tmp;
        }
        public string GetProductosAsJson()
        {
            return JsonConvert.SerializeObject(productos);
        }
        public Producto[] ordenar()
        {
            Array.Sort(productos, new Producto.ProductoPrecioCompare());
            return productos;
		}
		public int GetLastProductoId()
		{
			if (productos == null)
			{
				return 0;
			}
			else if (productos.Length == 0)
			{
				return 0;
			}
			else
			{
                return productos[productos.Length - 1].Id;
			}
			
		}
	}
}
