﻿using System.Collections.Generic;
using System.Linq;
using XFCustomControls.Models;

namespace XFCustomControls.Servicos
{
    public class PopulaListaSubCategorias
    {
        public List<SubCategoria> Popula(int categoria)
        {
            var _subCategorias = new List<SubCategoria>();
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 1, NomeSubCategoria = "Restaurantes", IdCategoria = 1, Ordem = 1 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 2, NomeSubCategoria = "Pizzarias", IdCategoria = 1, Ordem = 2 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 3, NomeSubCategoria = "Hamburguerias", IdCategoria = 1, Ordem = 3 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 4, NomeSubCategoria = "Adegas", IdCategoria = 1, Ordem = 4 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 5, NomeSubCategoria = "Açougues", IdCategoria = 1, Ordem = 5 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 6, NomeSubCategoria = "Culinária Oriental", IdCategoria = 1, Ordem = 6 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 7, NomeSubCategoria = "Supermercados", IdCategoria = 1, Ordem = 7 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 8, NomeSubCategoria = "Cafés e Padarias", IdCategoria = 1, Ordem = 8 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 9, NomeSubCategoria = "Bares", IdCategoria = 1, Ordem = 9 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 10, NomeSubCategoria = "Milk Shake", IdCategoria = 1, Ordem = 10 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 11, NomeSubCategoria = "Empório", IdCategoria = 1, Ordem = 11 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 12, NomeSubCategoria = "Pastelaria", IdCategoria = 1, Ordem = 12 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 13, NomeSubCategoria = "Esfiharia", IdCategoria = 1, Ordem = 13 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 14, NomeSubCategoria = "Frango Assado", IdCategoria = 1, Ordem = 14 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 15, NomeSubCategoria = "Lanchonete", IdCategoria = 1, Ordem = 15 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 16, NomeSubCategoria = "Confecção", IdCategoria = 2, Ordem = 1 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 17, NomeSubCategoria = "Calçados", IdCategoria = 2, Ordem = 2 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 35, NomeSubCategoria = "Uniformes", IdCategoria = 2, Ordem = 3 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 18, NomeSubCategoria = "Escolas", IdCategoria = 3, Ordem = 1 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 19, NomeSubCategoria = "Publicidade", IdCategoria = 3, Ordem = 2 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 20, NomeSubCategoria = "Cursos", IdCategoria = 3, Ordem = 3 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 21, NomeSubCategoria = "Posto de Combustível", IdCategoria = 3, Ordem = 4 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 22, NomeSubCategoria = "Auto Moto Escola", IdCategoria = 3, Ordem = 5 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 23, NomeSubCategoria = "Bicicletarias", IdCategoria = 3, Ordem = 6 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 24, NomeSubCategoria = "Corretor de Imóveis", IdCategoria = 3, Ordem = 7 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 25, NomeSubCategoria = "Corretor de Seguros", IdCategoria = 3, Ordem = 8 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 26, NomeSubCategoria = "Contabilidade", IdCategoria = 3, Ordem = 9 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 27, NomeSubCategoria = "Assistência Técnica", IdCategoria = 3, Ordem = 10 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 28, NomeSubCategoria = "Arcondicionado", IdCategoria = 3, Ordem = 11 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 29, NomeSubCategoria = "Segurança Patrimonial", IdCategoria = 3, Ordem = 12 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 30, NomeSubCategoria = "Comunicação Visual", IdCategoria = 3, Ordem = 13 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 31, NomeSubCategoria = "Dedetização", IdCategoria = 3, Ordem = 14 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 32, NomeSubCategoria = "Chaveiro", IdCategoria = 3, Ordem = 15 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 33, NomeSubCategoria = "Crédito Pessoal", IdCategoria = 3, Ordem = 16 });
            _subCategorias.Add(new SubCategoria { IdSubCategoria = 34, NomeSubCategoria = "Fretes e Carretos", IdCategoria = 3, Ordem = 17 });

            _subCategorias = _subCategorias.Where(x => x.IdCategoria == categoria).OrderBy(x => x.Ordem).ToList();
            return _subCategorias;
        }

    }
}
