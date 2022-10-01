import { Component, OnInit } from '@angular/core';
import { ServDataFormService } from 'src/app/services/serv-data-form.service';
import { modDataForm } from 'src/app/models/modDataForm';

@Component({
  selector: 'app-query-form',
  templateUrl: './query-form.component.html',
  styleUrls: ['./query-form.component.scss']
})
export class QueryFormComponent implements OnInit {
  cantidadMujeres;
  cantidadHombres;
  promedioEdad;
  personaMayor: modDataForm[];

  constructor(public queryService: ServDataFormService) { }

  ngOnInit(): void {
    this.queryService.getUsersSer();
  }

  cantMujeres(){
    this.queryService.getCountMujeres().subscribe (cantidad => { this.cantidadMujeres = cantidad});
  }

  cantHombres(){
    this.queryService.getCountHombres().subscribe (cantidad => { this.cantidadHombres = cantidad});
  }

  avgEdades(){
    this.queryService.getPromedioEdad().subscribe (cantidad => { this.promedioEdad = cantidad});
  }

  quienEsMayor(){
    //Anotation
      this.queryService.mayorDeLaLista().subscribe(mayor =>  { this.personaMayor = mayor as modDataForm[]});
  }
}
