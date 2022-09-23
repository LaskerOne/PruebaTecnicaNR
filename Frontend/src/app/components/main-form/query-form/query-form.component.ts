import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ServDataFormService } from 'src/app/services/serv-data-form.service';

@Component({
  selector: 'app-query-form',
  templateUrl: './query-form.component.html',
  styleUrls: ['./query-form.component.scss']
})
export class QueryFormComponent implements OnInit {
  form: FormGroup;

  constructor(public queryService: ServDataFormService) { }

  ngOnInit(): void {
    this.queryService.getUsersSer();
  }

  sendQuery(){
    console.log("hago la peticion para mostrar en la tabla el resultado del servicio");
  }

}
