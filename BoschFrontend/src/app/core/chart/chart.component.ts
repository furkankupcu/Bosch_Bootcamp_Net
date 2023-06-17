import { Component, OnInit } from '@angular/core';
import { NgChartsModule } from 'ng2-charts';
import { Chart, registerables} from 'chart.js';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, map } from 'rxjs';
import { HttpClientService } from 'src/app/services/common/http-client.service';
Chart.register(...registerables);

@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.css']
})

export class ChartComponent implements OnInit{
  
  constructor(private httpClientService : HttpClientService){}

  ngOnInit(): void {
    let resultData: ChartData[]
    const chartData$: Observable<ChartData[]> = this.getChartData();

    chartData$.subscribe((chartData: ChartData[]) => {
      resultData = chartData;
    });

    this.getChartData().subscribe((resultData: ChartData[]) => {
      this.RenderChart(resultData, 'pie', 'pieChart');
    });
  }
  
  RenderChart(resultData: ChartData[], type: any, id: any) {
    const labeldata = resultData.map(data => data.label);
    const maindata = resultData.map(data => data.data);
    //const colordata = resultData.map(() => this.getRandomColor()); // Rastgele renkler almak için bir fonksiyon kullanılıyor
    const colordata = ['red',"white", 'blue', 'green', 'yellow'];
    const myChart = new Chart(id, {
      type: type,
      data: {
        labels: labeldata,
        datasets: [{
          label: '# of Injectors',
          data: maindata,
          backgroundColor: colordata,
          borderColor: [
            'rgba(255, 99, 132, 1)'
          ],
          borderWidth: 1
        }]
      },
      options: {
        aspectRatio: 2,
        scales: {
          y: {
            display: false
          }
        }
      }
    });
  }

  getChartData(){
    return this.httpClientService.get<{ modelNumber: string, toplam: number }[]>({ controller: 'Injectors', action: 'ModelCount' }).pipe(
      map((data: { modelNumber: string, toplam: number }[]) => {
        const chartData: ChartData[] = data.map(item => ({
          label: item.modelNumber,
          data: item.toplam
        }));
        return chartData;
      })
  );
}

getRandomColor() {
  // Rastgele renk oluşturmak için kullanılabilir
  // İsteğe bağlı olarak rastgele renk oluşturan bir fonksiyon kullanabilirsiniz
  // Örnek olarak:
  const letters = '0123456789ABCDEF';
  let color = '#';
  for (let i = 0; i < 6; i++) {
    color += letters[Math.floor(Math.random() * 16)];
  }
  return color;
}

}

interface ChartData {
  label: string;
  data: number;
}