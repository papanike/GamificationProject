import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { HeaderComponent } from './components/header/header.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';

import { MatSelectModule } from '@angular/material/select';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatListModule } from '@angular/material/list';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatDialogModule } from '@angular/material/dialog';
import { MatOptionModule, MatNativeDateModule, MatRippleModule } from '@angular/material/core';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatMenuModule } from '@angular/material/menu';
import { MatIconModule } from '@angular/material/icon';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatCardModule } from '@angular/material/card';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatTabsModule } from '@angular/material/tabs';
import { MatRadioModule } from '@angular/material/radio';
import { MatButtonToggleModule } from '@angular/material/button-toggle';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatBottomSheetModule } from '@angular/material/bottom-sheet';
import { RegisterComponent } from './components/register/register.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HeaderComponent,
    DashboardComponent,
    RegisterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatButtonModule, MatCheckboxModule, MatSidenavModule, MatToolbarModule,
    MatMenuModule, MatIconModule, MatListModule, MatTableModule, MatPaginatorModule,
    MatCardModule, MatDialogModule, MatInputModule, MatOptionModule, MatSelectModule,
    MatProgressSpinnerModule, MatSnackBarModule, MatDatepickerModule, MatNativeDateModule,
    MatButtonToggleModule, MatExpansionModule, MatRippleModule, MatTabsModule, MatRadioModule,
    MatGridListModule, MatBottomSheetModule
  ], exports: [
    MatButtonModule, MatCheckboxModule, MatSidenavModule, MatToolbarModule,
    MatMenuModule, MatIconModule, MatListModule, MatTableModule, MatPaginatorModule,
    MatCardModule, MatDialogModule, MatInputModule, MatOptionModule, MatSelectModule,
    MatProgressSpinnerModule, MatSnackBarModule, MatDatepickerModule, MatNativeDateModule,
    MatButtonToggleModule, MatExpansionModule, MatRippleModule, MatTabsModule, MatRadioModule,
    MatGridListModule, MatBottomSheetModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
