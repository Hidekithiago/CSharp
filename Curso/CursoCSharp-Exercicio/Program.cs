
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text.RegularExpressions;
using static _4_bancoDados;
using static _5_api;
using static _6_excel;

namespace CursoCSharp_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Exercicio CLASSE
            Produto p1 = new Produto(1, "Produto1", 1.99);
            Produto p2 = new Produto(2, "Produto2", 1.99);
            Produto p3 = new Produto(3, "Produto3", 1.99);
            
            //EXERCICIO BANCO DE DADOS
            string[] formaPagamentoArray = {"Credito", "Debito", "Dinheiro", "Pix", "Boleto"};
            string formaPagamentoQuery = null;
            for(int i = 0; i < formaPagamentoArray.Length; i++) formaPagamentoQuery += $",('{formaPagamentoArray[i]}', 0, 'HIDEKI')";
            formaPagamentoQuery = Regex.Replace(formaPagamentoQuery, "^,", "");
            string query = "INSERT INTO formaPagamento(descricao, desconto, userName) values " + formaPagamentoQuery;
            //FormasPagamento.executaQuery(query);
            query = "Select * from formaPagamento where userName = 'Hideki'";
            var resultadaQuery = FormasPagamento.ConsultaQueryArmazena(query);
            List<FormasPagamento> formaPagamentoLista = new List<FormasPagamento>();
            foreach (DataTable table in resultadaQuery.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    var formaPagamentoObjeto = new FormasPagamento(Int32.Parse(row[0].ToString()), row[1].ToString(), Int32.Parse(row[2].ToString()), row[3].ToString());
                    formaPagamentoLista.Add(formaPagamentoObjeto);
                }                
            }
            for(int i = 0; i < formaPagamentoLista.Count; i++)
            {
                if (formaPagamentoLista[i].Nome.Equals("Pix") || formaPagamentoLista[i].Nome.Equals("Dinheiro")) formaPagamentoLista[i].Desconto = 25;
            }
            //EXERCICIO API
            //https://deckofcardsapi.com/
            Deck d1 = new Deck();
            Deck.CreateDeck(d1);
            Deck.DrawCard(d1);
            Deck.ValidaVencedor(d1);
        //createSheet(@"C:\Users\hidek\OneDrive\Área de Trabalho\GitHub\CSharp\Curso\Cursoexample_workbook.xlsx");
    }
    }
}
