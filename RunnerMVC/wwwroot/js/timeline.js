function chronicleTimeline() {
    return {
        activeTab: 'archive',
        selectedYear: new Date().getFullYear(),
        searchQuery: '',

        scrollToYear(year) {
            this.selectedYear = year;
            const yearSection = document.getElementById(`year-${year}`);
            if (yearSection) {
                yearSection.scrollIntoView({ 
                    behavior: 'smooth', 
                    block: 'start' 
                });
            }
        },

        scrollToToday() {
            const currentYear = new Date().getFullYear();
            this.scrollToYear(currentYear);
        },

        filterEvents() {
            // Implementar filtrado si es necesario
            console.log('Filtering:', this.searchQuery);
        }
    }
}   