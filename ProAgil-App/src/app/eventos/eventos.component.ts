import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  eventos: any = [];
  imagemAltura = 50;
  imagemMargem = 2;
  mostrarImagem = false;
  filtroLista = '';
                                                                                                                                                                                                                                                                                                                                                                                                      
   
  constructor(private http: HttpClient) { }                                                                         
 
  ngOnInit() {
    this.getEventos();
  }

  alternarImagem(){
    this.mostrarImagem = !this.mostrarImagem;
  }
  getEventos(){
    this.http.get('http://localhost:5000/api/values').subscribe(response =>{
        this.eventos = response
        console.log(response);
      } ,error => {
        console.log(error);
      });
  }

}
