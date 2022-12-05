import { Component, OnInit } from '@angular/core';
import {
  AbstractControlOptions,
  FormBuilder,
  FormGroup,
  Validators,
} from '@angular/forms';
import { ValidatorField } from '@app/helpers/ValidatorField';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss'],
})
export class RegistrationComponent implements OnInit {
  public form: FormGroup = new FormGroup({});

  public get formControls(): any {
    return this.form.controls;
  }

  constructor(private _formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.validation();
  }

  private validation(): void {
    const formOptions: AbstractControlOptions = {
      validators: ValidatorField.MustMatch('senha', 'confirmarSenha'),
    };

    this.form = this._formBuilder.group(
      {
        primeiroNome: ['', Validators.required],
        ultimoNome: ['', Validators.required],
        email: ['', [Validators.required, Validators.email]],
        usuario: ['', Validators.required],
        senha: ['', [Validators.required, Validators.minLength(6)]],
        confirmarSenha: ['', Validators.required],
      },
      formOptions
    );
  }

  protected resetForm(): void {
    this.form.reset();
  }
}
