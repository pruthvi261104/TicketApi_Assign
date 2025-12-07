
import { Component,signal } from '@angular/core';
import { CommonModule,DatePipe } from '@angular/common';
import { TicketService } from '../../services/ticket-service';

@Component({
  selector: 'app-tickets',
  imports: [CommonModule,DatePipe],
  templateUrl: './tickets.html',
  styleUrl: './tickets.css',
})
export class Tickets {
tickets=signal<any[]>([]);
constructor(private ticketService:TicketService){
  this.loadOrders();
}
loadOrders(){
  this.ticketService.getTickets().subscribe(data=>{
    this.tickets.set(data);
  });
}
}
