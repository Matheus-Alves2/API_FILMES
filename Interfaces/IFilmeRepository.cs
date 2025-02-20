﻿using api_filmes_senai.Domains;

namespace api_filmes_senai.Interfaces
{
    public interface IFilmeRepository
    {
        void Cdastrar(Filme novoFilme);

        List<Filme> Listar();

        void Atualizar(Guid id, Filme filme);

        void Deletar(Guid id);

        Filme BuscarPorId(Guid id);
    }
}
