import { Component, OnInit } from '@angular/core';
import {
  AbstractControlOptions,
  FormBuilder,
  FormGroup,
  Validators,
} from '@angular/forms';
import { ValidatorField } from '@app/helpers/ValidatorField';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.scss'],
})
export class PerfilComponent implements OnInit {
  public form: FormGroup = new FormGroup({});

  public get formControls(): any {
    return this.form.controls;
  }

  onSubmit():void {
    if(this.form.invalid){
      return;
    }
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
        titulo: ['', Validators.required],
        primeiroNome: ['', Validators.required],
        ultimoNome: ['', Validators.required],
        email: ['', [Validators.required, Validators.email]],
        telefone: ['', Validators.required],
        funcao: ['', Validators.required],
        descricao: ['', [Validators.required, Validators.maxLength(250)]],
        senha: ['', [Validators.minLength(6)]],
        confirmarSenha: [''],
      },
      formOptions
    );
  }

  protected resetForm(): void {
    this.form.reset();
  }
}
