import { Injectable } from '@angular/core';
import {
  ActivatedRouteSnapshot,
  CanActivate,
  Router,
  RouterStateSnapshot,
  UrlTree,
} from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate {
  constructor(private _router: Router, private _toaster: ToastrService) {}

  canActivate() {
    if (localStorage.getItem('user') !== null)
      return true;

    this._toaster.info('Usuário não autenticado!');
    this._router.navigate(['/user/login']);
    return false;
  }
}
