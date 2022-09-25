import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainFormComponent } from './components/main-form/main-form.component';
import { DataFormComponent } from './components/main-form/data-form/data-form.component';
import { ViewFormComponent } from './components/main-form/view-form/view-form.component';
import { QueryFormComponent } from './components/main-form/query-form/query-form.component';

@NgModule({
  declarations: [
    AppComponent,
    MainFormComponent,
    DataFormComponent,
    ViewFormComponent,
    QueryFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
