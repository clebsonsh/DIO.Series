using System;
using System.Collections.Generic;
using DIO.Series.src.Interfaces;

namespace DIO.Series.src.Classes
{
	public class SerieRepository : IRepository<Serie>
	{
        private List<Serie> listSerie = new List<Serie>();
		public void Create(Serie entity)
		{
			throw new NotImplementedException();
		}

		public void Destroy(int id)
		{
			throw new NotImplementedException();
		}

		public List<Serie> List()
		{
			throw new NotImplementedException();
		}

		public int NextId()
		{
			throw new NotImplementedException();
		}

		public Serie ReturnById(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(int id, Serie entity)
		{
			throw new NotImplementedException();
		}
	}
}
