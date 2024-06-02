import { Component } from '@angular/core';
import { AuthService } from '../../auth.service';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: 'login.component.html',
})
export class LoginComponent {
  formData = {
    username: '',
    password: '',
    isLoged: false,
  };

  constructor(private authService: AuthService, private router: Router) {}

  login() {
    if (
      this.formData.username === 'Liza' &&
      this.formData.password === '1111'
    ) {
      this.authService.login();
      this.formData.isLoged = true;
      this.router.navigate(['/dashboard']);
      console.log('zalogowano pomyślnie');
    } else {
      this.authService.logout();
      this.formData.isLoged = false;
      console.log('błąd logowania');
    }
  }
}
