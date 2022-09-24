import { Component, OnInit } from '@angular/core';
import { ServDataFormService } from 'src/app/services/serv-data-form.service';
import { __values } from 'tslib';

@Component({
  selector: 'app-view-form',
  templateUrl: './view-form.component.html',
  styleUrls: ['./view-form.component.scss']
})
export class ViewFormComponent implements OnInit {

  constructor(public getService: ServDataFormService) { }

  ngOnInit(): void {
    this.getService.getUsersSer();
  }

  deleteUser(id: number) {
    if(confirm("¿Seguro que desea eliminar el registro?")){
      this.getService.deleteUser(id).subscribe(data => {
        console.log("registro eliminado");
        this.getService.getUsersSer();
      });
    }
  }

  editUser(user){
    this.getService.updateUser(user)
  }


}
