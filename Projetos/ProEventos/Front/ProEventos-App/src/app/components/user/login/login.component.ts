import { AccountService } from './../../../services/account.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserLogin } from '@app/models/Identity/UserLogin';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {
  protected model = {} as UserLogin;

  constructor(
    private _accountService: AccountService,
    private _router: Router,
    private _toaster: ToastrService
  ) {}

  ngOnInit(): void {}

  public login(): void {
    this._accountService.login(this.model).subscribe({
      next: () => this._router.navigateByUrl('/dashboard'),
      error: (e) => {
        if (e.status == 401) this._toaster.error('Usuário ou senha inválidos');
        else console.error(e);
      },
    });
  }
}
