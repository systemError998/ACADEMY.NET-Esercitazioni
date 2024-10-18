import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaDestinazioniComponent } from './lista-destinazioni.component';

describe('ListaDestinazioniComponent', () => {
  let component: ListaDestinazioniComponent;
  let fixture: ComponentFixture<ListaDestinazioniComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ListaDestinazioniComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListaDestinazioniComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
