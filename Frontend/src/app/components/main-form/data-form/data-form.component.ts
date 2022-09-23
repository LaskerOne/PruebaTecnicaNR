import { Component, OnDestroy, OnInit } from '@angular/core';
import {FormGroup, FormBuilder, Validators} from '@angular/forms';
import { Subscription } from 'rxjs';
import { modDataForm } from 'src/app/models/modDataForm';
import { ServDataFormService } from 'src/app/services/serv-data-form.service';

@Component({
  selector: 'app-data-form',
  templateUrl: './data-form.component.html',
  styleUrls: ['./data-form.component.scss']
})
export class DataFormComponent implements OnInit, OnDestroy {
  [x: string]: any;
  form: FormGroup;
  sucription: Subscription;
  usuario: modDataForm;
  idUsuario = 0;

  constructor(private formBuilder: FormBuilder,
              private userServ: ServDataFormService) {
    this.form = this.formBuilder.group({
      id: 0,
      document: ['',[Validators.required, Validators.minLength(7)]],
      firstName: ['',[Validators.required, Validators.minLength(3)]],
      secondName: ['',[]],
      lastName: ['',[Validators.required, Validators.minLength(3)]],
      lastName2: ['',[]],
      phone: ['',[]],
      email: ['',[]],
      address: ['',[Validators.required]],
      age: [,[Validators.required, Validators.min(18), Validators.max(80), Validators.maxLength(2)]],
      genre: ['',[Validators.required]]

    })
   }
  ngOnDestroy(): void {
    this.sucription.unsubscribe();
  }

  ngOnInit(): void {
    this.suscription = this.userServ.getRegisterToUpdate().subscribe(data => {
      console.log(data);
      this.usuario = data;
      this.form.patchValue({
        document: this.usuario.document,
        firstName: this.usuario.firstName,
        secondName: this.usuario.secondName,
        lastName: this.usuario.lastName,
        lastName2: this.usuario.lastName2,
        phone: this.usuario.phone,
        email: this.usuario.email,
        address: this.usuario.address,
        age: this.usuario.age,
        genre: this.usuario.genre
      });
    });
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
      console.log("Registro guardado exitosamente");
      this.userServ.getUsersSer();
      this.form.reset();
    });
  }

}
