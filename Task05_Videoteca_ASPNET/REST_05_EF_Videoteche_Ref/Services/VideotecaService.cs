using Microsoft.EntityFrameworkCore.Metadata;
using REST_05_EF_Videoteche_Ref.Models;
using REST_05_EF_Videoteche_Ref.Repos;
using System.Collections.Generic;

namespace REST_05_EF_Videoteche_Ref.Services
{
    public class VideotecaService : IService<VideotecaDTO>
    {
        private readonly VideotecaRepo _repository;

        public VideotecaService(VideotecaRepo repository)
        {
            _repository = repository;
        }

        //METODI CRUD 
        public VideotecaDTO? Cerca(string varCod)
        {
            VideotecaDTO? risultato = null;

            Videoteca? videoteca = _repository.GetByCodice(varCod);
            if (videoteca is not null)
            {
                risultato = new VideotecaDTO()
                {
                    Cod = videoteca.Codice,
                    Ind = videoteca.Indirizzo,
                    Nom = videoteca.Nome
                };
            }

            return risultato;
        }

        public List<VideotecaDTO> Lista()
        {
            List<VideotecaDTO> risultato = new List<VideotecaDTO>();

            IEnumerable<Videoteca> elencoVideoteche = _repository.GetAll();

            foreach (Videoteca videoteca in elencoVideoteche)
            {
                if (videoteca is not null) {
                    VideotecaDTO videotecaTemp = new VideotecaDTO()
                    {
                        Cod = videoteca.Codice,
                        Ind = videoteca.Indirizzo,
                        Nom = videoteca.Nome
                    };

                    risultato.Add(videotecaTemp);
                }
            }

            return risultato;
        }

        public bool EliminaVideoteca(string varCodi) {

            bool ris = false;

            Videoteca? videotecaDaEliminare = _repository.GetByCodice(varCodi);
            if (videotecaDaEliminare is not null)
                ris = _repository.Delete(videotecaDaEliminare.Codice);

            return ris;
        }

        public bool InserisciVideoteca(VideotecaDTO vidDto)
        {
            bool ris = false;

            if (vidDto.Nom is not null || vidDto.Ind is not null)
            {
                Videoteca? video = new Videoteca()
                {
                    Codice = vidDto.Cod is not null ? vidDto.Cod : Guid.NewGuid().ToString().ToUpper(),
                    Indirizzo = vidDto.Ind,
                    Nome = vidDto.Nom
                };

                return _repository.Create(video);
                
            }

            return ris;
        }

        public bool ModificaVideoteca(VideotecaDTO vidDTOmod)
        {
            bool ris = false;

            if (vidDTOmod is not null && !string.IsNullOrWhiteSpace(vidDTOmod.Cod))
            {
                //
                var videotecaDaModificare = _repository.GetByCodice(vidDTOmod.Cod);

                if (videotecaDaModificare is not null)
                {
                    if (!string.IsNullOrWhiteSpace(vidDTOmod.Nom))
                    {
                        videotecaDaModificare.Nome = vidDTOmod.Nom;
                    }

                    if (!string.IsNullOrWhiteSpace(vidDTOmod.Ind))
                    {
                        videotecaDaModificare.Indirizzo = vidDTOmod.Ind;
                    }

                    if (_repository.Update(videotecaDaModificare))
                    {
                        ris = true;
                    }
                }
                
            }
            return ris;
        }
    }
}
