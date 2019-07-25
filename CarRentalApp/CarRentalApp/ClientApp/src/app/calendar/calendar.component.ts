import {
  Component,
  ChangeDetectionStrategy,
  ViewChild,
  AfterViewInit,
  TemplateRef
} from '@angular/core';
import {
  startOfDay,
  endOfDay,
  subDays,
  addDays,
  endOfMonth,
  isSameDay,
  isSameMonth,
  addHours
} from 'date-fns';
import { Subject, from } from 'rxjs';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import {
  CalendarEvent,
  CalendarEventAction,
  CalendarEventTimesChangedEvent,
  CalendarView
} from 'angular-calendar';
import { Rentals } from '../models/rentals';
import { debug } from 'util';
import { CalendarEventActionsComponent } from 'angular-calendar/modules/common/calendar-event-actions.component';
const colors: any = {
  red: {
    primary: '#ad2121',
    secondary: '#FAE3E3'
  },
  blue: {
    primary: '#1e90ff',
    secondary: '#D1E8FF'
  },
  yellow: {
    primary: '#e3bc08',
    secondary: '#FDF1BA'
  }
};

@Component({
  selector: 'app-calendar',
  changeDetection: ChangeDetectionStrategy.OnPush,
  styleUrls: ['calendar.component.css'],
  templateUrl: 'calendar.component.html'
})
export class CalendarComponent implements AfterViewInit {
  @ViewChild('modalContent', { static: true }) modalContent: TemplateRef<any>;

  view: CalendarView = CalendarView.Month;

  CalendarView = CalendarView;

  viewDate: Date = new Date();

  selectedDate: Date = new Date();

  modalData: {
    action: string;
    event: CalendarEvent;
  };

  actions: CalendarEventAction[] = [
    {
      label: '<i class="fa fa-fw fa-pencil"></i>',
      onClick: ({ event }: { event: CalendarEvent }): void => {
        this.handleEvent('Edited', event);
      }
    },
    {
      label: '<i class="fa fa-fw fa-times"></i>',
      onClick: ({ event }: { event: CalendarEvent }): void => {
        this.events = this.events.filter(iEvent => iEvent !== event);
        this.handleEvent('Deleted', event);

      }
    }
  ];

  refresh: Subject<any> = new Subject();

  events: CalendarEvent[] = [

    {
      start: subDays(startOfDay(new Date()), 0),
      end: addDays(new Date(), 2),
      title: 'A 3 day event',
      color: colors.red,
      actions: this.actions,
      allDay: true,
      resizable: {
        beforeStart: true,
        afterEnd: true
      },
      draggable: true
    },

  ];

  activeDayIsOpen: boolean = true;

  constructor(private modal: NgbModal) { }

  ngAfterViewInit() {

   

    // TODO: Refactorizare cod !!
    let x = document.getElementsByClassName("cal-day-cell");
    let i;
    let date = new Date();

   // let a = this.dayClicked({ date, events: CalendarEvent[this.events] });
    for (i = 0; i < x.length; i++) {

      if (i >= 9 && i <= 17) {
        x[i].style.backgroundColor = "red";
      }
     
        if (i >= 19 && i <= 23) {
          x[i].style.backgroundColor = "green";
        }
      
      console.log(x[i].childNodes[2].childNodes[1].innerHTML);
    }
  }

  dayClicked({ date, events }: { date: Date; events: CalendarEvent[] }): void {


    if (this.selectedDate.getDate() != date.getDate()) {
      this.selectedDate = date;
      events.push({
        start: subDays(startOfDay(new Date()), 2),
        end: addDays(new Date(), 3),
        title: 'A 3 day event',
        color: colors.blue,
        actions: this.actions,
        allDay: true,
        resizable: {
          beforeStart: true,
          afterEnd: true
        },
        draggable: true
      })
      this.refresh;
    }
    if (isSameMonth(date, this.viewDate)) {
      if (
        (isSameDay(this.viewDate, date) && this.activeDayIsOpen === true) ||
        events.length === 0
      ) {
        this.activeDayIsOpen = false;
      } else {
        this.activeDayIsOpen = true;
      }
      this.viewDate = date;
    }
  }

  eventTimesChanged({
    event,
    newStart,
    newEnd
  }: CalendarEventTimesChangedEvent): void {
    this.events = this.events.map(iEvent => {
      if (iEvent === event) {
        return {
          ...event,
          start: newStart,
          end: newEnd
        };
      }
      return iEvent;
    });
    this.handleEvent('Dropped or resized', event);
  }

  handleEvent(action: string, event: CalendarEvent): void {
    this.modalData = { event, action };
    this.modal.open(this.modalContent, { size: 'lg' });
  }

  addEvent(): void {
    this.events = [
      ...this.events,
      {
        title: 'New event',
        start: startOfDay(new Date()),
        end: endOfDay(new Date()),
        color: colors.red,
        draggable: true,
        resizable: {
          beforeStart: true,
          afterEnd: true
        }
      }
    ];
  }

  deleteEvent(eventToDelete: CalendarEvent) {
    this.events = this.events.filter(event => event !== eventToDelete);
  }

  setView(view: CalendarView) {
    this.view = view;
  }

  closeOpenMonthViewDay() {
    this.activeDayIsOpen = false;
  }
}
