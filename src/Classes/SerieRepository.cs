using System;
using System.Collections.Generic;
using DIO.Series.src.Interfaces;

namespace DIO.Series
{
	public class SerieRepository : IRepository<Serie>
	{
        private List<Serie> listSerie = new List<Serie>();
		public void Add(Serie serie)
		{
            listSerie.Add(serie);
		}

		public void Destroy(int id)
		{
            listSerie[id].destroy();
		}

		public List<Serie> List()
		{
            return listSerie;
		}

		public int NextId()
		{
            return listSerie.Count;
		}

		public Serie ReturnById(int id)
		{
            return listSerie[id];
		}

		public void Update(int id, Serie serie)
		{
            listSerie[id] = serie;
		}
	}
}
