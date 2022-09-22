import { Component, OnInit } from '@angular/core';
import {FormGroup, FormBuilder, Validators} from '@angular/forms';
import { modDataForm } from 'src/app/models/modDataForm';
import { ServDataFormService } from 'src/app/services/serv-data-form.service';

@Component({
  selector: 'app-data-form',
  templateUrl: './data-form.component.html',
  styleUrls: ['./data-form.component.scss']
})
export class DataFormComponent implements OnInit {
  form: FormGroup;

  constructor(private formBuilder: FormBuilder,
              private userServ: ServDataFormService) {
    this.form = this.formBuilder.group({
      id: 0,
      document: ['',[Validators.required, Validators.minLength(7)]],
      firstName: ['',[Validators.required, Validators.minLength(3)]],
      secondName: ['',[Validators.minLength(3)]],
      lastName: ['',[Validators.required, Validators.minLength(3)]],
      lastName2: ['',[Validators.minLength(3)]],
      phone: ['',[]],
      email: ['',[]],
      address: ['',[Validators.required]],
      age: [,[Validators.required, Validators.min(18), Validators.max(80)]],
      genre: ['',[Validators.required]]

    })
   }

  ngOnInit(): void {
  }

  sendForm() {
    const userInfo: modDataForm = {
      document: this.form.get('document').value,
      firstName: this.form.get('firstName').value,
      secondName: this.form.get('secondName').value,
      lastName: this.form.get('lastName').value,
      lastName2: this.form.get('lastName2').value,
      phone: this.form.get('phone').value,
      email: this.form.get('email').value,
      address: this.form.get('address').value,
      age: this.form.get('age').value,
      genre: this.form.get('genre').value
    }

    this.userServ.saveUser(userInfo).subscribe(data => {
      console.log("Datos Guardados");
      this.form.reset();
    });
  }

}
