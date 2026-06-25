using RunnerMVC.Models;
using System.Globalization;

namespace RunnerMVC.Services
{
    public class TimelineService : ITimelineService
    {
        private readonly List<TimelineEvent> _events;

        public TimelineService()
        {
            // Datos de ejemplo basados en la imagen
            _events = new List<TimelineEvent>
            {
                new TimelineEvent
                {
                    Id = 1,
                    Fecha = new DateTime(2024, 5, 15),
                    Titulo = "La Cumbre Energética redefine el panorama de las renovables en Europa",
                    Descripcion = "Líderes de veintiséis naciones acuerdan un marco histórico para acelerar la transición energética, priorizando la soberanía tecnológica y el hidrógeno verde.",
                    Categoria = "Economía Global",
                    EnlaceCompleto = "#"
                },
                new TimelineEvent
                {
                    Id = 2,
                    Fecha = new DateTime(2024, 5, 12),
                    Titulo = "Inteligencia Artificial: El dilema de la autoría en las artes visuales",
                    Descripcion = "Una investigación profunda sobre cómo los nuevos algoritmos están desafiando las leyes de propiedad intelectual y la esencia de la creatividad humana.",
                    Categoria = "Cultura Digital",
                    EnlaceCompleto = "#"
                },
                new TimelineEvent
                {
                    Id = 3,
                    Fecha = new DateTime(2024, 4, 28),
                    Titulo = "Avances en la fusión nuclear: El camino hacia la energía inagotable",
                    Descripcion = "Científicos logran mantener el plasma estable por tiempo récord, acercándonos a una realidad de energía limpia y barata.",
                    Categoria = "Ciencia",
                    EnlaceCompleto = "#"
                },
                new TimelineEvent
                {
                    Id = 4,
                    Fecha = new DateTime(2023, 12, 10),
                    Titulo = "Revolución en la educación digital",
                    Descripcion = "Nuevas plataformas de aprendizaje adaptativo transforman la manera de enseñar en todo el mundo.",
                    Categoria = "Educación",
                    EnlaceCompleto = "#"
                },
                new TimelineEvent
                {
                    Id = 5,
                    Fecha = new DateTime(2023, 8, 5),
                    Titulo = "Descubrimiento arqueológico en América Latina",
                    Descripcion = "Hallazgo de una ciudad precolombina revela nuevos datos sobre civilizaciones antiguas.",
                    Categoria = "Historia",
                    EnlaceCompleto = "#"
                },
                new TimelineEvent
                {
                    Id = 6,
                    Fecha = new DateTime(2022, 11, 20),
                    Titulo = "Avances en medicina regenerativa",
                    Descripcion = "Nuevas técnicas de células madre prometen tratamientos revolucionarios.",
                    Categoria = "Medicina",
                    EnlaceCompleto = "#"
                }
            };
        }

        public List<TimelineEvent> GetAllEvents()
        {
            return _events.OrderByDescending(e => e.Fecha).ToList();
        }

        public Dictionary<int, List<TimelineEvent>> GetEventsByYear()
        {
            return _events
                .OrderByDescending(e => e.Fecha)
                .GroupBy(e => e.Fecha.Year)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        public List<int> GetAvailableYears()
        {
            return _events
                .Select(e => e.Fecha.Year)
                .Distinct()
                .OrderByDescending(y => y)
                .ToList();
        }

        public TimelineEvent? GetEventById(int id)
        {
            return _events.FirstOrDefault(e => e.Id == id);
        }
    }
}