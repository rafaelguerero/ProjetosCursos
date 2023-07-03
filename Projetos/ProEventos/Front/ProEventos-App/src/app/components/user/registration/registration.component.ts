import { Component, OnInit } from '@angular/core';
import {
  AbstractControlOptions,
  FormBuilder,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Router } from '@angular/router';
import { ValidatorField } from '@app/helpers/ValidatorField';
import { User } from '@app/models/Identity/User';
import { AccountService } from '@app/services/account.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss'],
})
export class RegistrationComponent implements OnInit {
  public form: FormGroup = new FormGroup({});
  protected user = {} as User;

  public get formControls(): any {
    return this.form.controls;
  }

  onSubmit(): void {
    if (this.form.invalid) {
      return;
    }
  }

  constructor(
    private _formBuilder: FormBuilder,
    private _accountService: AccountService,
    private _router: Router,
    private _toaster: ToastrService
  ) {}

  ngOnInit(): void {
    this._validation();
  }

  private _validation(): void {
    const formOptions: AbstractControlOptions = {
      validators: ValidatorField.MustMatch('password', 'confirmarPassword'),
    };

    this.form = this._formBuilder.group(
      {
        primeiroNome: ['', Validators.required],
        ultimoNome: ['', Validators.required],
        email: ['', [Validators.required, Validators.email]],
        userName: ['', Validators.required],
        password: ['', [Validators.required, Validators.minLength(6)]],
        confirmarPassword: ['', Validators.required],
      },
      formOptions
    );
  }

  protected register(): void {
    this.user = { ...this.form.value };
    this._accountService.register(this.user).subscribe({
      next: () => this._router.navigateByUrl('/dashboard'),
      error: (e: any) => this._toaster.error(e.error),
    });
  }

  protected resetForm(): void {
    this.form.reset();
  }
}
