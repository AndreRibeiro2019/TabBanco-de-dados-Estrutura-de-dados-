﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabBanco_de_dados;
using TabBanco_de_dados.Entidades;


namespace TabBanco_de_Dados.Controllers
{
    public class UsuariosController : Controller
    {
        public readonly Contexto db;
        public UsuariosController(Contexto banco)
        {
            db = banco;
        }
        // GET: UsuariosController
        public ActionResult Index()
        {
            return View(db.USUARIOS.ToList());
        }



        // GET: UsuariosController/Details/5

        // GET: UsuariosController/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: UsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(usuario collection)
        {
            db.USUARIOS.Add(collection);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        // GET: UsuariosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View( db.USUARIOS.Where(a => a.Id == id).FirstOrDefault()  );

        }



        // POST: UsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, usuario collection)
        {
            db.USUARIOS.Update(collection);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }




    }
}