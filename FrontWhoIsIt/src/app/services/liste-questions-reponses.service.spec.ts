import { TestBed } from '@angular/core/testing';

import { ListeQuestionsReponsesService } from './liste-questions-reponses.service';

describe('ListeQuestionsReponsesService', () => {
  let service: ListeQuestionsReponsesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ListeQuestionsReponsesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
